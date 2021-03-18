import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { filter, map  } from 'rxjs/operators';

@Injectable({
    providedIn: 'root'
})
export class UploadFilesService  {

    private baseUrl: string;

    constructor(private http: HttpClient) {
       
        this.baseUrl = '/Asset/Add';
    }

    handleError(e:any) {

    }

    postFile(fileToUpload: File): any {
        const endpoint = this.baseUrl;
        const formData: FormData = new FormData();
        formData.append('fileKey', fileToUpload, fileToUpload.name);
        return this.http
            .post(endpoint, formData, {})
            .subscribe(data => {
                //debugger;
            });
            //.map(() => { return true; })
            //.catch((e) => this.handleError(e));
    }
}


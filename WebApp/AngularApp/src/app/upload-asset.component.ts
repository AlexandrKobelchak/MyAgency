import { Component } from '@angular/core';
import { UploadFilesService } from '../_services/upload-files.service';

@Component({
    selector: 'upload-file',
    template: '<div class="form-group">\
        <label for="file">Choose File</label >\
        <input type="file" id = "file"\
        (change) = "handleFileInput($event.target.files)" />\
        <button (click)="uploadFileToActivity()" >Send</button>\
        </div>',
    styles: []
})
export class UploadFileComponent {

    fileToUpload: File = null;

    constructor(private uploadFileService: UploadFilesService) {

    }

    handleFileInput(files: FileList) {
        this.fileToUpload = files.item(0);
    }

    uploadFileToActivity() {
        debugger;
        this.uploadFileService.postFile(this.fileToUpload).subscribe(data => {
            // do something, if upload success
        }, error => {
            console.log(error);
        });
    }
}
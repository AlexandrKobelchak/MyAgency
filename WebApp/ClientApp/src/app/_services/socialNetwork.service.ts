import { Injectable } from '@angular/core';
import { HttpClient, HttpHeaders } from '@angular/common/http';
import { Observable, throwError } from 'rxjs';
import { SocialNetworkViewModel } from "src/_models/socialNetworkViewModel";
import { catchError } from "rxjs/operators";
import { Service } from '../_generic/Service';
import { IService } from '../_abstract/IService';


@Injectable({
    providedIn: 'root'
})
export class SocialNetworkService extends Service<SocialNetworkViewModel> implements IService<SocialNetworkViewModel> {

    
    constructor(http: HttpClient) {
      super(http);
      this.baseUrl = 'api/Social';
    }
}

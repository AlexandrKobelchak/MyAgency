import { Injectable } from '@angular/core';
import { HttpClient, HttpHeaders } from '@angular/common/http';
import { Observable, throwError } from 'rxjs';
import { TagViewModel } from "src/_models/clientTagViewModel";
import { catchError } from "rxjs/operators";
import { Service } from '../_generic/Service';
import { IService } from '../_abstract/IService';


@Injectable({
  providedIn: 'root'
})
export class ClientTagService extends Service<TagViewModel> implements IService<TagViewModel> {


  constructor(http: HttpClient) {
    super(http);
    this.baseUrl = 'api/TouristTag';
  }
}

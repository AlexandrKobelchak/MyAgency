import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';
import { first, flatMap, shareReplay } from 'rxjs/operators';
import { ClientModel } from 'src/_models/clientModel';
import { Guid } from 'guid-typescript';
import { Service } from '../_generic/Service';
import { IService } from '../_abstract/IService';


@Injectable({
    providedIn: 'root'
})
export class ClientService extends Service<ClientModel> implements IService<ClientModel> {

  constructor(http: HttpClient) {
      super(http);
      this.baseUrl = 'api/Clientage';
  }
}

import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';
import { first, flatMap, shareReplay } from 'rxjs/operators';
import { ClientModel } from 'src/_models/clientModel';
import { Guid } from 'guid-typescript';


@Injectable({
    providedIn: 'root'
})
export class ClientService {

  private allClients$: Observable<ClientModel[]>;

  private baseUrl = 'api/Clientage';

  constructor(private http: HttpClient) {

  }

  public getAllclients(): Observable<ClientModel[]> {
    if (!this.allClients$) {
      this.allClients$ = ((this.http.get<ClientModel[]>(this.baseUrl).pipe(shareReplay())) as any);
    }
    return this.allClients$;
  }
  getClientId(id: Guid): Observable<ClientModel> {
    return this.getAllclients().pipe(flatMap(result => result), first<ClientModel>(lan => (lan.id === id)));
  }
  addClient(client: ClientModel): Observable<ClientModel> {
    return this.http.post<ClientModel>(this.baseUrl, client);
  }
  updateClient(client: ClientModel): Observable<ClientModel> {
    return this.http.put<ClientModel>(this.baseUrl, client);
  }
  deleteClient(id: Guid): Observable<any> {
    return this.http.delete(this.baseUrl + '/'+ id);
  }
  clearCache() {
    this.allClients$ = null;
  }

}

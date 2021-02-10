import { HttpClient } from "@angular/common/http";
import { Injectable } from "@angular/core";
import { Guid } from "guid-typescript";
import { Observable } from "rxjs";
import { first, flatMap, shareReplay } from "rxjs/operators";
import { IModel } from "../_interfaces/IModel";
import { IService } from "../_interfaces/IService";

@Injectable({
  providedIn: 'root'
})
export class Service<T extends IModel> implements IService<T> {

  private allItems: Observable<T[]>;
  protected baseUrl: string;

  constructor(private http: HttpClient) { }

  public getAllItems(): Observable<T[]> {
    if (!this.allItems) {
      this.allItems = ((this.http.get<IModel[]>(this.baseUrl).pipe(shareReplay())) as any);
    }
    return this.allItems;
  }
  public getItemById(id: Guid): Observable<T> {
    return this.getAllItems().pipe(flatMap(result => result), first<T>(lan => (lan.id === id)));
  }
  addItem(item: T): Observable<T> {
    return this.http.post<T>(this.baseUrl, item);
  }
  updateItem(item: T): Observable<T> {
    return this.http.put<T>(this.baseUrl, item);
  }
  deleteItem(id: Guid): Observable<any> {
    return this.http.delete(this.baseUrl + '/' + id);
  }
  clearCache() {
    this.allItems = null;
  }
}

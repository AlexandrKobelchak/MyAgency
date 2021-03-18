import { Guid } from "guid-typescript";
import { Observable } from "rxjs";
import { IModel } from "./IModel";

export interface IService<T extends IModel> {
  getAllItems(): Observable<T[]>;
  getItemById(id: Guid): Observable<T>;
  addItem(item: T): Observable<T>
  updateItem(item: T): Observable<T>;
  deleteItem(id: Guid): Observable<any>;
}

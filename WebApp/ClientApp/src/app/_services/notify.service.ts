import {Injectable} from '@angular/core';

@Injectable({
  providedIn: 'root'
})
export class NotifyService {

    constructor() {}
 
  public success = (msg: string) => {
    
  }

  public error = (message: string) => {
  }

  public warning = (message: string) => {
  }

}

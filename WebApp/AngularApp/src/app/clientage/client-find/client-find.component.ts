import { Component, Input, Output, EventEmitter } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { ClientModel } from '../../../_models/clientModel';

@Injectable()
export class HttpService {

  constructor(private http: HttpClient) { }

  getData(value: string) {
    return this.http.post('api/FindClient', {"findText" : value});
  }
}


@Component({
  selector: '<add-find>',
  templateUrl: './client-find.component.html',
  providers: [HttpService]
})
export class ClientFindComponent {
  @Input() findText: string;
  @Output() findTextChange = new EventEmitter<string>();

  public clients: ClientModel[];

  constructor(private httpService: HttpService) {

  }

  onTextChange(model: string) {

    this.findText = model;
    this.findTextChange.emit(model);

    if (this.findText.length > 3) {
      this.httpService.getData(this.findText)
        .subscribe((data: ClientModel[]) => {
          this.clients = data;
          debugger;
        })        
    }
  }
}

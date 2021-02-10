import { Component, OnInit } from '@angular/core';
import { HttpClient } from '@angular/common/http';



@Component({
	selector: 'clientage',
	templateUrl: './clientage.component.html',
	styleUrls: []
})
export class ClientageComponent implements OnInit {

  constructor(private http: HttpClient) {

	}

	private allClients: any[];

  ngOnInit(): void {
    this.http.get('api/Clientage')
			
      .subscribe((data: any[]) => {

        //debugger;

        this.allClients = data;
		});
	}

	actionDelete(): void {
		this.http.delete("api/Clientage");
	}
}

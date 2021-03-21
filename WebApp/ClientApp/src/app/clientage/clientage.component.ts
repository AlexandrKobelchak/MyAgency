import { Component } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { ClientService } from '../../_services/client.service';
import { ClientModel } from '../../_models/clientModel';




@Component({
	selector: 'clientage',
	template: '<client-menu></client-menu>\
		<router-outlet></router-outlet>',
	styleUrls: []
})
export class ClientageComponent{

	
}

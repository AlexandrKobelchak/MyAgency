import { Directive, Component, Inject, OnInit, Input, Output, EventEmitter,  ElementRef, HostListener, forwardRef } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observer } from 'rxjs';
import { PHONE_MODES, PhonesSharedState, PHONES_SHARED_STATE } from '../../../_models/touristPhonesState.model';
import { Guid } from "guid-typescript";
import { FormGroupName, FormGroup, FormControl, Validators, AbstractControl, } from '@angular/forms'
import { ClientPhoneModel, ClientPhoneSocial } from "../../../_models/clientModel";
import { SocialNetworkService } from "../../../_services/socialNetwork.service";
import { SocialNetworkViewModel } from '../../../_models/socialNetworkViewModel';
import { Ng2TelInputModule, Ng2TelInput } from 'ng2-tel-input';
import { Validator, NG_VALIDATORS } from '@angular/forms';

import { PhoneValidator } from "src/app/_common/phone.component/phone.component";
import { PhoneComponent } from "src/app/_common/phone.component/phone.component";


@Component({
    selector: '<client-phones>',
    templateUrl: './client-phones.component.html',
    styleUrls: ['./client-phones.component.css']
})
export class ClientPhonesComponent {

    social: SocialNetworkViewModel[];

  
    constructor(
        private socialService: SocialNetworkService,
        @Inject(PHONES_SHARED_STATE) private stateEvents: Observer<PhonesSharedState>
    ){
        
    }

    ngOnInit(): void {

        this.socialService.getAllItems().subscribe((data: SocialNetworkViewModel[]) => {

            let social = new Array<SocialNetworkViewModel>();
            data.map(function (val: any, i: number, arr: any[]) {
                social.push(new SocialNetworkViewModel(val.id, val.name, false));
            });
            this.social = social;
        });
    }

    private clientPhones = [new ClientPhoneModel];

    addPhone = () => {
        this.clientPhones.push(new ClientPhoneModel);

    }
    removePhone = (i: number) => {       
        this.clientPhones.splice(i, 1);
    }

    onChangeCheck(data: any): void {
        let update = new PhonesSharedState(PHONE_MODES.CREATE, new Array<ClientPhoneModel>());
       
        this.stateEvents.next(update);
    }
}

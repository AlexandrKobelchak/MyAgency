import { Component, Inject } from '@angular/core';
import { ClientPhonesComponent } from '../client-phones/client-phones.component';
import { ClientModel } from 'src/_models/clientModel';
import { ClientService } from 'src/_services/client.service';
import { NgForm } from '@angular/forms';
import { TAG_MODES, TagsSharedState, TAGS_SHARED_STATE } from "src/_models/touristTagState.model";
import { PHONE_MODES, PhonesSharedState, PHONES_SHARED_STATE } from "src/_models/touristPhonesState.model";
import { Observable } from 'rxjs';
import { faEdit, faMailBulk } from '@fortawesome/free-solid-svg-icons';
import { library } from '@fortawesome/fontawesome-svg-core';


@Component({
    selector: '<add-client>',
    templateUrl: './client-add.component.html',
    styleUrls: ['./client-add.component.css']
})
export class ClientAddComponent {

    faEdit = faEdit;
    faMailBulk = faMailBulk;
    clientModel = new ClientModel;
    formSubmitted = false;

    constructor(
        private clientService: ClientService,
        @Inject(TAGS_SHARED_STATE) private stateEvents: Observable<TagsSharedState>,
        @Inject(PHONES_SHARED_STATE) private phoneEvents: Observable<PhonesSharedState>) {

        stateEvents.subscribe(update => {

            debugger;
        });

        phoneEvents.subscribe(update => {

            debugger;
        });
    }

    getValidationMessages(state: any, thingName?: string) {
        let thing: string = state.path || thingName;
        let messages: string[] = [];
        if (state.errors) {
            for (let errorName in state.errors) {
                switch (errorName) {
                    case "required":
                        messages.push(`You must enter a ${thing}`);
                        break;
                    case "minlength":
                        messages.push(`A ${thing} must be at least ${state.errors['minlength'].requiredLength} characters`);
                        break;
                    case "pattern":
                        messages.push(`The ${thing} contains illegal characters`);
                        break;
                }
            }
        }
        return messages;
    }

    getFormValidationMessages(form: NgForm): string[] {
        let messages: string[] = [];
        Object.keys(form.controls).forEach(k => {
            this.getValidationMessages(form.controls[k], k)
                .forEach(m => messages.push(m));
        });
        return messages;
    }

    onSubmit = (/*form: NgForm*/) => {

        debugger;
    }


}

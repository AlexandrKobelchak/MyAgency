import { InjectionToken } from "@angular/core";
import { ClientPhoneModel, ClientPhoneSocial } from "src/_models/clientModel";

export enum PHONE_MODES {
    CREATE, EDIT
}

export class PhonesSharedState {

    constructor(public mode: PHONE_MODES, public phones?: ClientPhoneModel[]) { }
}

export const PHONES_SHARED_STATE = new InjectionToken("phones_shared_state");

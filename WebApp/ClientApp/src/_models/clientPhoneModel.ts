import {IModel} from "../_abstract/IModel";
import {Guid} from "guid-typescript";
import {ClientPhoneSocial} from "./clientPhoneSocial";

export class ClientPhoneModel implements IModel {
    public id: Guid;
    public number: string;
    public sendSMS: boolean;
    public social: ClientPhoneSocial[];
}
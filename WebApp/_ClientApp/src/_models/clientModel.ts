import { Guid } from 'guid-typescript';
import { IModel } from '../_interfaces/IModel';
import { TagViewModel } from './clientTagViewModel'

export class ClientPhoneSocial implements IModel {
    public id: Guid;
    public name: string;
}

export class ClientPhoneModel implements IModel{
    public id: Guid;
    public number: string;
    public sendSMS: boolean;
    public social: ClientPhoneSocial[];
}

export class ClientModel implements IModel{

    public id: Guid;
    public firstName: string;
    public middleName: string;
    public lastName: string;
    public phones: ClientPhoneModel[];
    public touristTags: TagViewModel[];
}

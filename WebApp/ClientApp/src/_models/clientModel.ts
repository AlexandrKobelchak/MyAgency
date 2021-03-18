import {Guid} from 'guid-typescript';
import {IModel} from '../_abstract/IModel';
import {TagViewModel} from './clientTagViewModel'
import {ClientPhoneModel} from "./clientPhoneModel";

export class ClientModel implements IModel{

    public id: Guid;
    public firstName: string;
    public middleName: string;
    public lastName: string;
    public phones: ClientPhoneModel[];
    public touristTags: TagViewModel[];
}

import { Guid } from "guid-typescript";
import { IModel } from "../_interfaces/IModel";


export class SocialNetworkViewModel implements IModel {

    constructor(
        public id: Guid,
        public name: string,
        public isChecked: boolean)
    {
    }
}

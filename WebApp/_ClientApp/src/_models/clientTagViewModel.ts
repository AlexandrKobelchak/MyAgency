import { Guid } from "guid-typescript";
import { IModel } from "../_interfaces/IModel";


export class TagViewModel implements IModel {

    constructor(
        public id: Guid,
        public tagName: string,
        public isChecked: boolean)
    {
    }
}

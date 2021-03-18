import { Guid } from "guid-typescript";
import { IModel } from "../_abstract/IModel";


export class TagViewModel implements IModel {

    constructor(
        public id: Guid,
        public tagName: string,
        public isChecked: boolean)
    {
    }
}

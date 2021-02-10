import { InjectionToken } from "@angular/core";
import { Guid } from "guid-typescript";

export enum TAG_MODES {
    CREATE, EDIT
}

export class TagsSharedState {

    constructor(public mode: TAG_MODES, public ids?: Guid[]) { }
}

export const TAGS_SHARED_STATE = new InjectionToken("tags_shared_state");

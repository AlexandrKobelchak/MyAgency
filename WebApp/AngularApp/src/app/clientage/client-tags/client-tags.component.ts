import { Component, Inject, OnInit } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observer } from 'rxjs';
import { TAG_MODES, TagsSharedState, TAGS_SHARED_STATE } from "src/_models/touristTagState.model";
import { Guid } from "guid-typescript";
import { TagViewModel } from "src/_models/clientTagViewModel";
import { ClientTagService } from "src/_services/clientTags.service";

@Component({
  selector: 'client-tags',
  templateUrl: './client-tags.component.html',
  styleUrls: ['./client-tags.component.css']
})

export class ClientTagsComponent implements OnInit {

    public tags : TagViewModel[];

    constructor(        
        @Inject(TAGS_SHARED_STATE) private stateEvents: Observer<TagsSharedState>
        ,private tagService: ClientTagService
    ) {
    }

    ngOnInit(): void {

        this.tagService.getAllItems().subscribe((data: TagViewModel[]) => {
            
            let tags = new Array<TagViewModel>();
            data.map(function (val: any, i: number, arr: any[]) {
                tags.push(new TagViewModel(val.id, val.tagName, false ));
            });
            this.tags = tags;
            
        });
    }

    onChangeCheck(data:any): void {
        let update = new TagsSharedState(TAG_MODES.CREATE, new Array<Guid>());
        this.tags.map(function (item: TagViewModel, index: number, arr: TagViewModel[]) {
            if (item.isChecked)
                update.ids.push(item.id);
        });
        this.stateEvents.next(update);
    }
}

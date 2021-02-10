import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { HttpClientModule, HTTP_INTERCEPTORS } from '@angular/common/http';
//import { NgxIntlTelInputModule } from 'ngx-intl-tel-input';
//import { BsDropdownModule } from 'ngx-bootstrap';

import { ClientageRoutingModule } from './clientage.routing'
import { ClientageComponent } from './clientage.component';
import { ClientTagsComponent } from './client-tags/client-tags.component';
import { ClientAddComponent } from './client-add/client-add.component';
import { ClientFindComponent } from './client-find/client-find.component';
import { ClientPhonesComponent } from './client-phones/client-phones.component';
import { ClientMenuComponent } from './client-menu/client-menu.component';
import { TagsSharedState, TAGS_SHARED_STATE } from 'src/_models/touristTagState.model';
import { PhonesSharedState, PHONES_SHARED_STATE } from 'src/_models/touristPhonesState.model';
import { Subject } from "rxjs";
import { ClientTagService } from "src/_services/clientTags.service";
import { SocialNetworkService } from "src/_services/socialNetwork.service";
import { Ng2TelInputModule } from 'ng2-tel-input';

import { PhoneValidator } from "src/app/_common/phone.component/phone.component";
import { PhoneComponent } from "src/app/_common/phone.component/phone.component";

@NgModule({
    declarations: [
        ClientageComponent,
        ClientTagsComponent,
        ClientAddComponent,
        ClientFindComponent,
        ClientPhonesComponent,
        ClientMenuComponent,
        PhoneComponent,
        PhoneValidator,
    ],
    imports: [        
        BrowserModule.withServerTransition({ appId: 'ng-cli-universal' }),
        HttpClientModule,
        FormsModule,
        ClientageRoutingModule,
//        NgxIntlTelInputModule,
//        BsDropdownModule,
        ReactiveFormsModule,
        Ng2TelInputModule
    ],
    
    providers: [
        { provide: TAGS_SHARED_STATE, useValue: new Subject<TagsSharedState>() },
        { provide: PHONES_SHARED_STATE, useValue: new Subject<PhonesSharedState>() },
        { provide: ClientTagService, useClass: ClientTagService },
        { provide: SocialNetworkService, useClass: SocialNetworkService }  
    ]
    
})
export class ClientageModule { }

import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { ClientAddComponent } from './client-add/client-add.component';
import { ClientFindComponent } from './client-find/client-find.component';
import { ClientageComponent } from './clientage.component';

import { AuthorizeGuard } from 'src/api-authorization/authorize.guard';


const routes: Routes = [
    {
        path: 'clientage', component: ClientageComponent, children: [
            { path: 'add', component: ClientAddComponent, canActivate: [AuthorizeGuard]  },
            { path: 'find', component: ClientFindComponent, canActivate: [AuthorizeGuard]  },
        ]
    }
];

@NgModule({
    imports: [RouterModule.forChild(routes)],
    exports: [RouterModule]
})
export class ClientageRoutingModule { }

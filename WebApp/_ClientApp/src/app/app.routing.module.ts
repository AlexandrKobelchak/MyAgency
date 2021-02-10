import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';


import { HomeComponent } from './home/home.component';
import { CounterComponent } from './counter/counter.component';
import { MailingComponent } from './mailing/mailing.component';
import { OptionsComponent } from './options/options.component';
import { PaymentsComponent } from './payments/payments.component';
import { FetchDataComponent } from './fetch-data/fetch-data.component';


import { ApiAuthorizationModule } from 'src/api-authorization/api-authorization.module';
import { AuthorizeGuard } from 'src/api-authorization/authorize.guard';
import { AuthorizeInterceptor } from 'src/api-authorization/authorize.interceptor';


const routes: Routes = [
    //{ path: '', redirectTo: 'home', pathMatch: 'full' },
    { path: '', component: HomeComponent, pathMatch: 'full' },
    { path: 'clientage', redirectTo: 'clientage/find', pathMatch: 'full' },

    { path: 'counter', component: CounterComponent },
    { path: 'fetch-data', component: FetchDataComponent, canActivate: [AuthorizeGuard] },
   
    { path: 'options', component: OptionsComponent, canActivate: [AuthorizeGuard] },
    { path: 'payments', component: PaymentsComponent, canActivate: [AuthorizeGuard] },
    { path: 'mailing', component: MailingComponent, canActivate: [AuthorizeGuard] },
];

@NgModule({
    imports: [RouterModule.forRoot(routes, { scrollPositionRestoration: 'enabled' })],
    exports: [RouterModule]
})
export class AppRoutingModule { }

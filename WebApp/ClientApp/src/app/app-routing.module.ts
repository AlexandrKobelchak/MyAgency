import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import {HomeComponent} from "./home/home.component";
import {BisnessComponent} from "./bisness/bisness.component";
import {OptionsComponent} from "./options/options.component";
import {PaymentsComponent} from "./payments/payments.component";
import {MailingComponent} from "./mailing/mailing.component";
import {StatisticComponent} from "./statistic/statistic.component";

const routes: Routes = [
  { path: '', component: HomeComponent, pathMatch: 'full' },
  //{ path: 'clientage', redirectTo: 'clientage/find', pathMatch: 'full' },
  { path: 'home', component: HomeComponent, },
  //{ path: 'clientage', component: ClientageComponent, },
  { path: 'bisness', component: BisnessComponent, },
  { path: 'options', component: OptionsComponent, },
  { path: 'payments', component: PaymentsComponent,  },
  { path: 'mailing', component: MailingComponent, },
  { path: 'statistic', component: StatisticComponent, },
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }

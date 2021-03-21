import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import {FontAwesomeModule} from "@fortawesome/angular-fontawesome";
import {FormsModule, ReactiveFormsModule} from "@angular/forms";
import {NgxIntlTelInputModule} from "ngx-intl-tel-input";
import {BrowserAnimationsModule} from "@angular/platform-browser/animations";
import {NavMenuComponent} from "./nav-menu/nav-menu.component";
import {HomeComponent} from "./home/home.component";
import {MailingComponent} from "./mailing/mailing.component";
import {OptionsComponent} from "./options/options.component";
import {PaymentsComponent} from "./payments/payments.component";
import {StatisticComponent} from "./statistic/statistic.component";
import {BisnessComponent} from "./bisness/bisness.component";
import {ClientageModule} from "./clientage/clientage.module";
import {PhoneComponent} from "./_common/phone.component/phone.component";

@NgModule({
  declarations: [
    AppComponent,
    NavMenuComponent,
    HomeComponent,
    MailingComponent,
    OptionsComponent,
    PaymentsComponent,
    StatisticComponent,
    BisnessComponent,
      PhoneComponent
  ],
  imports: [
    BrowserModule,
    BrowserAnimationsModule,
    AppRoutingModule,
    FontAwesomeModule,
    FormsModule,
    ReactiveFormsModule,
    NgxIntlTelInputModule,
    ClientageModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }

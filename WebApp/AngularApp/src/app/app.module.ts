import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';

import { AppRoutingModule } from './app.routing.module';
import { AppComponent } from './app.component';
import { FontAwesomeModule } from '@fortawesome/angular-fontawesome';
import { MailingComponent } from './mailing/mailing.component';
import { OptionsComponent } from './options/options.component';
import { NavMenuComponent } from './nav-menu/nav-menu.component';
import { PaymentsComponent } from './payments/payments.component';
import { PhoneComponent, PhoneValidator } from './_common/phone.component/phone.component';
import { HomeComponent } from './home/home.component';
import { StatisticComponent } from './statistic/statistic.component';
import { BisnessComponent } from './bisness/bisness.component';
import { ClientageModule } from './clientage/clientage.module';
import { ReactiveFormsModule } from '@angular/forms';
import { RouterModule } from '@angular/router';

@NgModule({
  declarations: [
        AppComponent,
        NavMenuComponent,
        HomeComponent,
        MailingComponent,
        OptionsComponent,
        StatisticComponent,
        PaymentsComponent,
        PhoneComponent,
        PhoneValidator,
        BisnessComponent       
        
  ],
  imports: [
      BrowserModule,
      AppRoutingModule,
      
      AppRoutingModule,
      ClientageModule,
      RouterModule,
      ReactiveFormsModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }

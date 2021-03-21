import { Directive, Component, Inject, OnInit, Input, Output, EventEmitter, ElementRef, HostListener, forwardRef } from '@angular/core';
import { Validator, NG_VALIDATORS, ValidationErrors } from '@angular/forms';
import { FormGroupName, FormGroup, FormControl, Validators, AbstractControl, } from '@angular/forms'
import {CountryISO, PhoneNumberFormat, SearchCountryField} from "ngx-intl-tel-input";





@Component({
    selector: 'phone',
    templateUrl: 'phone.component.html',
    styles: ['input.ng-dirty.ng-invalid { border: 2px solid #ff0000 !important }',
        'input.ng-dirty.ng-valid { border: 2px solid #6bc502 !important  }'
    ]
})
export class PhoneComponent {

    noError: boolean;
    number;
    id: string;

    separateDialCode = false;
    searchCountryField = SearchCountryField;
    countryISO = CountryISO;
    phoneNumberFormat = PhoneNumberFormat;
    preferredCountries: CountryISO[] = [CountryISO.Russia, CountryISO.Ukraine];


}

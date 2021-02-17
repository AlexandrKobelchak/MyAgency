import { Directive, Component, Inject, OnInit, Input, Output, EventEmitter, ElementRef, HostListener, forwardRef } from '@angular/core';
import { Ng2TelInputModule, Ng2TelInput } from 'ng2-tel-input';
import { Validator, NG_VALIDATORS, ValidationErrors } from '@angular/forms';
import { FormGroupName, FormGroup, FormControl, Validators, AbstractControl, } from '@angular/forms'
//import { debug } from 'util';


@Component({
    selector: 'phone',
    template: '<div></div>',
    styles: ['input.ng-dirty.ng-invalid { border: 2px solid #ff0000 !important }',
        'input.ng-dirty.ng-valid { border: 2px solid #6bc502 !important  }'
    ]
})
export class PhoneComponent {

    number: string;

    telInput: any;

    telInputOptions = {
        allowDropdown: true,
        autoHideDialCode: false,
        autoPlaceholder: "polite",
        customContainer: "",
        customPlaceholder: null,
        dropdownContainer: null,
        excludeCountries: [],
        formatOnDisplay: true,
        geoIpLookup: null,
        hiddenInput: "",
        initialCountry: "ua",
        localizedCountries: null,
        nationalMode: false,
        onlyCountries: ["al", "ad", "at", "by", "be", "ba", "bg", "hr", "cz", "dk",
            "ee", "fo", "fi", "fr", "de", "gi", "gr", "va", "hu", "is", "ie", "it", "lv",
            "li", "lt", "lu", "mk", "mt", "md", "mc", "me", "nl", "no", "pl", "pt", "ro",
            "ru", "sm", "rs", "sk", "si", "es", "se", "ch", "ua", "gb"],
        placeholderNumberType: "MOBILE",
        preferredCountries: ["ua", "ru"],
        separateDialCode: true
    }

    errorMap = ["Invalid number", "Invalid country code", "Too short", "Too long", "Invalid number"];

    hasError(noError: boolean) {
        
      
    }
    getNumber(number: string) {
        this.number = number;
    }
    telInputObject(telInput: any) {
        
        this.telInput = telInput;
        
    }
    
    onCountryChange(event: object) {
        
    }
}

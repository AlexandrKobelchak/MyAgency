import { Directive, Component, Inject, OnInit, Input, Output, EventEmitter, ElementRef, HostListener, forwardRef } from '@angular/core';
import { Ng2TelInputModule, Ng2TelInput } from 'ng2-tel-input';
import { Validator, NG_VALIDATORS, ValidationErrors } from '@angular/forms';
import { FormGroupName, FormGroup, FormControl, Validators, AbstractControl, } from '@angular/forms'
//import { debug } from 'util';

export class PhoneComponentData {

    number: string;
    error: any;

    phoneComponent: PhoneComponent;

    constructor(phone: PhoneComponent) {
        this.phoneComponent = phone;
    }

    GetPhoneComponent(): PhoneComponent {
        return this.phoneComponent;
    }
}

@Directive({
    selector:
        '[phoneValidator]',
    providers: [
        { provide: NG_VALIDATORS, useExisting: PhoneValidator, multi: true }
    ]
})
export class PhoneValidator implements Validator {

    @Input('phoneComponentData') phoneComponentData: PhoneComponentData;

    constructor(private el: ElementRef) {
    }


    validate(control: AbstractControl): { [key: string]: any } {

        if (this.phoneComponentData.phoneComponent.number) return null;


        return {
            isPhone: {
                invalid: true
            }
        };
        // console.log(c.value + " is a number");
        return null;
    }
}
@Component({
    selector: 'phone',
    template: '<input type="text" class="form-control" id="phone_{{i}}" \
           required phoneValidator ngModel  \
           ng2TelInput \
           phoneComponentData="phoneComponentData"\
           ng2TelInputOptions = "telInputOptions" \
           (hasError)="hasError($event)" \
           (ng2TelOutput) = "getNumber($event)" \
           (intlTelInputObject) = "telInputObject($event)"\
           (countryChange) = "onCountryChange($event)" \
    />',
    styles: ['input.ng-dirty.ng-invalid { border: 2px solid #ff0000 !important }',
        'input.ng-dirty.ng-valid { border: 2px solid #6bc502 !important  }'
    ]
})
export class PhoneComponent {

    public noError: boolean;
    public number;
    i: number;

    phoneComponentData: PhoneComponentData = new PhoneComponentData(this);

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
    } as any;

    errorMap = ["Invalid number", "Invalid country code", "Too short", "Too long", "Invalid number"];

    hasError(noError: boolean) {

        if (this.noError = noError) {
            console.log(this.telInput.getNumber());
            this.phoneComponentData.error = null;
            this.phoneComponentData.number = this.number;
        }
        else {
            console.log(this.errorMap[this.telInput.getValidationError()]);
            this.phoneComponentData.number = this.number = undefined;
            this.phoneComponentData.error = this.errorMap[this.telInput.getValidationError()];
        }
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

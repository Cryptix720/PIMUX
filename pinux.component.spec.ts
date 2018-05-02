/// <reference path="node_modules/@types/jasmine/index.d.ts" />
import { TestBed, async, ComponentFixture, ComponentFixtureAutoDetect } from '@angular/core/testing';
import { BrowserModule, By } from "@angular/platform-browser";
import { PinuxComponent } from './pinux.component';

let component: PinuxComponent;
let fixture: ComponentFixture<PinuxComponent>;

describe('PINUX component', () => {
    beforeEach(async(() => {
        TestBed.configureTestingModule({
            declarations: [ PinuxComponent ],
            imports: [ BrowserModule ],
            providers: [
                { provide: ComponentFixtureAutoDetect, useValue: true }
            ]
        });
        fixture = TestBed.createComponent(PinuxComponent);
        component = fixture.componentInstance;
    }));

    it('should do something', async(() => {
        expect(true).toEqual(true);
    }));
});
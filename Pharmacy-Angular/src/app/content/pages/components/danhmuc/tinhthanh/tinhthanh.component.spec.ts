/* tslint:disable:no-unused-variable */
import { async, ComponentFixture, TestBed } from '@angular/core/testing';
import { By } from '@angular/platform-browser';
import { DebugElement } from '@angular/core';

import { TinhthanhComponent } from './tinhthanh.component';

describe('TinhthanhComponent', () => {
  let component: TinhthanhComponent;
  let fixture: ComponentFixture<TinhthanhComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ TinhthanhComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(TinhthanhComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});

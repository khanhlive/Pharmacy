/* tslint:disable:no-unused-variable */

import { TestBed, async, inject } from '@angular/core/testing';
import { TinhthanhService } from './tinhthanh.service';

describe('Service: Tinhthanh', () => {
  beforeEach(() => {
    TestBed.configureTestingModule({
      providers: [TinhthanhService]
    });
  });

  it('should ...', inject([TinhthanhService], (service: TinhthanhService) => {
    expect(service).toBeTruthy();
  }));
});

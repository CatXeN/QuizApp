/* tslint:disable:no-unused-variable */

import { TestBed, async, inject } from '@angular/core/testing';
import { DashboardServiceService } from './dashboard-service.service';

describe('Service: DashboardService', () => {
  beforeEach(() => {
    TestBed.configureTestingModule({
      providers: [DashboardServiceService]
    });
  });

  it('should ...', inject([DashboardServiceService], (service: DashboardServiceService) => {
    expect(service).toBeTruthy();
  }));
});

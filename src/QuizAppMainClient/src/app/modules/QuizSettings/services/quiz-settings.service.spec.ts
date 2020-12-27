import { TestBed } from '@angular/core/testing';

import { QuizSettingsService } from './quiz-settings.service';

describe('QuizSettingsService', () => {
  let service: QuizSettingsService;

  beforeEach(() => {
    TestBed.configureTestingModule({});
    service = TestBed.inject(QuizSettingsService);
  });

  it('should be created', () => {
    expect(service).toBeTruthy();
  });
});

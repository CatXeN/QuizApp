import { ComponentFixture, TestBed } from '@angular/core/testing';

import { QuizSettingsViewComponent } from './quiz-settings-view.component';

describe('QuizSettingsViewComponent', () => {
  let component: QuizSettingsViewComponent;
  let fixture: ComponentFixture<QuizSettingsViewComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ QuizSettingsViewComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(QuizSettingsViewComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});

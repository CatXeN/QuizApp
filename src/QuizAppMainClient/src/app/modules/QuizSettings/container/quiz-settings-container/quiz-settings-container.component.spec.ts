import { ComponentFixture, TestBed } from '@angular/core/testing';

import { QuizSettingsContainerComponent } from './quiz-settings-container.component';

describe('QuizSettingsContainerComponent', () => {
  let component: QuizSettingsContainerComponent;
  let fixture: ComponentFixture<QuizSettingsContainerComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ QuizSettingsContainerComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(QuizSettingsContainerComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});

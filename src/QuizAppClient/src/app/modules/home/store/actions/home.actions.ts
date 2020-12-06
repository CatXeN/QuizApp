import { Quiz } from './../../../../shared/Models/quiz.model';
import { createAction, props } from '@ngrx/store';

export const LoadQuizzes = createAction('[Home Component] LoadQuizzes', props<{ quizzes: Quiz[]}>());
export const LoadQuizzesFail = createAction('[Home Component] LoadQuizzesFail', props<{ message: string }>());

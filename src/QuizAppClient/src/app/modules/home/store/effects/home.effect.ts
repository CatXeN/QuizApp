import { Quiz } from './../../../../shared/Models/quiz.model';
import { catchError, map, switchMap } from 'rxjs/operators';
import { QuizService } from './../../service/quiz.service';
import { LoadQuizzes } from './../actions/home.actions';
import { Actions, ofType, Effect } from '@ngrx/effects';
import * as reviewHome from '../actions/home.actions';
import { of } from 'rxjs';
import { Injectable } from '@angular/core';

@Injectable()
export class HomeEffects {
    @Effect()
    loadQuizzesEvent$ = this.actions$.pipe(
        ofType(LoadQuizzes),
        switchMap((action) =>
            this.homeService.getQuiz().pipe(
                map((quizzes: Quiz[]) => reviewHome.LoadQuizzes({quizzes})),
                catchError(error => of(reviewHome.LoadQuizzesFail(error)))
            )
        )
    );

    constructor(private actions$: Actions, private homeService: QuizService) {}
}



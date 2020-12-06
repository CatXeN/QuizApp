import { Quiz } from './../../../../shared/Models/quiz.model';
import * as HomeActions from '../actions/home.actions';
import { createReducer, on } from '@ngrx/store';
import { EntityState, EntityAdapter, createEntityAdapter } from '@ngrx/entity';

export const reviewAdapter: EntityAdapter<Quiz> = createEntityAdapter<Quiz>();

export interface HomeState extends EntityState<Quiz> {
    error: string;
}


export const initialHomeState: HomeState = reviewAdapter.getInitialState({
    error: ''
});

export const homeReducer = createReducer(initialHomeState,
    on(HomeActions.LoadQuizzes, (state) => {
        return {...state, error: ''};
    }));

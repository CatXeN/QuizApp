import { Quiz } from './../../../shared/models/quiz.model';
import { Observable } from 'rxjs';
import { Injectable } from '@angular/core';
import {HttpClient} from '@angular/common/http';
import {apiEndpoints} from '../../../core/http/api.endpoints';

@Injectable({
  providedIn: 'root'
})
export class QuizSettingsService {

  constructor(private http: HttpClient) { }

  getQuizById(model: string): Observable<Quiz> {
    return this.http.get<Quiz>(apiEndpoints.Quiz.getQuizById.format(String(model)));
  }
}

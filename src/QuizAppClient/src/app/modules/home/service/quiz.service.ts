import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { apiEndpoints } from 'src/app/core/http/api.ednpoints';
import { Quiz } from 'src/app/shared/Models/quiz.model';

@Injectable({
  providedIn: 'root'
})
export class QuizService {

constructor( private http: HttpClient) { }

  getQuiz(): Observable<Quiz[]> {
    return this.http.get<Quiz[]>(apiEndpoints.quiz.getQuiz);
  }
}

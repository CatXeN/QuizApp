import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { apiEndpoints } from 'src/app/core/http/api.ednpoints';
import { Quiz } from 'src/app/shared/Models/quiz.model';
import { Quest } from 'src/app/shared/Models/quest.model';
import 'src/app/core/extensions/string.formater';

@Injectable({
  providedIn: 'root'
})
export class QuizService {

constructor( private http: HttpClient) { }

  getQuiz(): Observable<Quiz[]> {
    return this.http.get<Quiz[]>(apiEndpoints.quiz.getQuiz);
  }
  GetQuestions(quizId: number): Observable<Quest[]> {
    return this.http.get<Quest[]>(apiEndpoints.quest.getQuest.format(String(quizId)));
  }
}

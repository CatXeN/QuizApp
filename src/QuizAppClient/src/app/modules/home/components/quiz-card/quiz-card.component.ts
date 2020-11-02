import { Component, OnInit } from '@angular/core';
import { QuizService } from '../../service/quiz.service';

@Component({
  selector: 'app-quiz-card',
  templateUrl: './quiz-card.component.html',
  styleUrls: ['./quiz-card.component.scss']
})
export class QuizCardComponent implements OnInit {

  constructor(private quizService: QuizService) { }

  quizList: any[];

  ngOnInit() {
    this.getQuizList();
  }

  getQuizList(): void {
    this.quizService.getQuiz().subscribe(x => {
      this.quizList = x;
    });
  }
}

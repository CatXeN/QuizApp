import { Quiz } from './../../../../shared/models/quiz.model';
import { Component, OnInit } from '@angular/core';
import {QuizSettingsService} from '../../services/quiz-settings.service';
import { ActivatedRoute } from '@angular/router';

@Component({
  selector: 'app-quiz-settings-view',
  templateUrl: './quiz-settings-view.component.html',
  styleUrls: ['./quiz-settings-view.component.scss']
})
export class QuizSettingsViewComponent implements OnInit {

  quizInfo: Quiz;

  constructor(private quizService: QuizSettingsService, private route: ActivatedRoute) { }

  ngOnInit(): void {
     this.getQuizInfo();
  }

  getQuizInfo(): void {
    this.quizService.getQuizById(this.route.snapshot.params.quizId).subscribe(x => {
      this.quizInfo = x;
      console.log(this.quizInfo)
    });
  }
}

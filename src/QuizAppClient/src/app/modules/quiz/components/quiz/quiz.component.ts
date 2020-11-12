import { Component, OnInit } from '@angular/core';
import { ActivatedRoute } from '@angular/router';
import { QuizService } from 'src/app/modules/home/service/quiz.service';
import { Quest } from 'src/app/shared/Models/quest.model';

@Component({
  selector: 'app-quiz',
  templateUrl: './quiz.component.html',
  styleUrls: ['./quiz.component.scss']
})
export class QuizComponent implements OnInit {

  id: string;
  quests: Quest[];

  constructor(private quizService: QuizService, private route: ActivatedRoute) { }

  ngOnInit(): void {
    this.GetIdFromUrl();
    this.GetQuestList();
  }

  GetIdFromUrl(){
    this.id = this.route.snapshot.paramMap.get('id');
  }

  GetQuestList(): void {
    this.quizService.GetQuestions(Number(this.id)).subscribe(x => {
      this.quests = x;
    })
  }

}

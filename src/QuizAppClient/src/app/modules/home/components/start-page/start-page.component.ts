import { Component, OnInit } from '@angular/core';
import { Category } from 'src/app/shared/Models/category.model';
import { CategoryService } from '../../service/category.service';
import { QuizCardComponent } from '../quiz-card/quiz-card.component';

@Component({
  selector: 'app-start-page',
  templateUrl: './start-page.component.html',
  styleUrls: ['./start-page.component.scss']
})
export class StartPageComponent implements OnInit {

  ngOnInit(): void {

  }
}

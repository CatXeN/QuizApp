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

  public burger: boolean = true;
  public username: string;
  categories: Category[];

  constructor(private categoryService: CategoryService) { }

  ngOnInit(): void {
    this.username = localStorage.getItem('username');
    this.getCategories();
  }

  isOpened(): void {
   this.burger = !this.burger;
  }

  getCategories(): void {
    this.categoryService.getCategory().subscribe(x => {
      this.categories = x;
    });
  }
}

import { Component, OnInit } from '@angular/core';
import { CategoryService } from 'src/app/modules/home/service/category.service';
import { Category } from 'src/app/shared/Models/category.model';
import { MaterialModule } from '../material';

@Component({
  selector: 'app-toolbar',
  templateUrl: './toolbar.component.html',
  styleUrls: ['./toolbar.component.scss']
})
export class ToolbarComponent implements OnInit {

  public burger: boolean = true;
  public username: string;
  public token: string;
  categories: Category[];

  constructor(private categoryService: CategoryService) { }

  ngOnInit(): void {
    this.username = localStorage.getItem('username');
    this.token = localStorage.getItem('token');

    this.getCategories();
  }

  getCategories(): void {
    this.categoryService.getCategory().subscribe(x => {
      this.categories = x;
    });
  }
}


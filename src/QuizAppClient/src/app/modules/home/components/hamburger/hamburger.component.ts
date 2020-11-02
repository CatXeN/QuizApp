import { Component, OnInit } from '@angular/core';
import { Category } from 'src/app/shared/Models/category.model';
import { CategoryService } from '../../service/category.service';


@Component({
  selector: 'app-hamburger',
  templateUrl: './hamburger.component.html',
  styleUrls: ['./hamburger.component.scss']
})
export class HamburgerComponent implements OnInit {

  categories: Category[];

  constructor(private categoryService: CategoryService) { }

  ngOnInit(): void {
    this.getCategories();
  }

  getCategories(): void {
    this.categoryService.getCategory().subscribe(x => {
      this.categories = x;
    });
  }
}

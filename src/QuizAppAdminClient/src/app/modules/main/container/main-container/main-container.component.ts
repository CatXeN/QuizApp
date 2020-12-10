import { CategoryService } from './../../services/Category.service';
import { Component, OnInit } from '@angular/core';
import { MatTableDataSource } from '@angular/material/table';
import { Category } from 'src/app/shared/models/category.model';

@Component({
  selector: 'app-main-container',
  templateUrl: './main-container.component.html',
  styleUrls: ['./main-container.component.scss']
})
export class MainContainerComponent implements OnInit {

  displayedColumns: string[] = ['id', 'name', 'doneQuizzes'];
  dataSource: MatTableDataSource<Category>;

  constructor(private categoryService: CategoryService) { }

  ngOnInit() {
    this.categoryService.getCatergories().subscribe(x => {
      this.dataSource = new MatTableDataSource(x);
      console.log(x);
    });
  }

  applyFilter(event: Event) {
    const filterValue = (event.target as HTMLInputElement).value;
    this.dataSource.filter = filterValue.trim().toLowerCase();
  }
}

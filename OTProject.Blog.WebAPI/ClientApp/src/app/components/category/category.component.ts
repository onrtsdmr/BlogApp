import {Component, OnInit} from '@angular/core';
import {CategoryService} from "../../services/category.service";
import {Category} from "../../models/Category";
import {AlertifyService} from "../../services/alertify.service";

@Component({
  selector: 'app-category',
  templateUrl: './category.component.html',
  styleUrls: ['./category.component.css']
})
export class CategoryComponent implements OnInit {

  categories: Category[];

  constructor(private categoryService: CategoryService, private alertifyService: AlertifyService) {
  }

  ngOnInit() {
    this.getCategories();
  }

  getCategories() {
    this.categoryService.getCategories()
      .subscribe(categories => {
        console.log("calışıyorum kardeş " + categories);
        this.categories = categories;
      }, error => {
        console.log("çalışmıyorum kardeş " + error.msg);
        this.alertifyService.error(error);
      });
  }

}

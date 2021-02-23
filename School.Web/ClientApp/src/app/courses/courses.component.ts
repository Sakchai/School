import { Component, Inject } from '@angular/core';
import { HttpClient } from '@angular/common/http';

@Component({
  selector: 'app-courses',
  templateUrl: './courses.component.html'
})
export class CoursesComponent {

  public courses: Course[];

  constructor(http: HttpClient, @Inject('BASE_URL') baseUrl: string) {
    http.get<Course[]>('https://localhost:44324/api/Courses').subscribe(result => {
      this.courses = result;
    }, error => console.error(error));
  }
}

interface Course {
  courseID: number;
  title: string;
  credits: number;
  enrollments: string;
}


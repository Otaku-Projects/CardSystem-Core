import { ComponentFixture, TestBed } from '@angular/core/testing';

import { UserListAndSearchComponent } from './list-and-search.component';

describe('UserListAndSearchComponent', () => {
  let component: UserListAndSearchComponent;
  let fixture: ComponentFixture<UserListAndSearchComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ UserListAndSearchComponent ]
    })
    .compileComponents();

    fixture = TestBed.createComponent(UserListAndSearchComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});

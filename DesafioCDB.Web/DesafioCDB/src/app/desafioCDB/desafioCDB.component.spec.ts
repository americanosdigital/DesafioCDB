import { ComponentFixture, TestBed } from '@angular/core/testing';

import { DesafioCDBComponent } from './desafioCDB.component';

describe('ResgateAplicacaoComponent', () => {
  let component: DesafioCDBComponent;
  let fixture: ComponentFixture<DesafioCDBComponent>;

  beforeEach(() => {
    TestBed.configureTestingModule({
      declarations: [DesafioCDBComponent]
    });
    fixture = TestBed.createComponent(DesafioCDBComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});

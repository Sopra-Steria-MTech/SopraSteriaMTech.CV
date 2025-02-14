import { ComponentFixture, TestBed } from '@angular/core/testing';

import { KennisComponent } from './kennis.component';

describe('KennisComponent', () => {
  let component: KennisComponent;
  let fixture: ComponentFixture<KennisComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [KennisComponent]
    })
    .compileComponents();
    
    fixture = TestBed.createComponent(KennisComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});

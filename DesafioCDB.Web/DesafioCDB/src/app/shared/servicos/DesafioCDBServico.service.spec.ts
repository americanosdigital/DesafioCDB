import { TestBed } from '@angular/core/testing';

import { DesafioCDBServico } from './DesafioCDBServico.service';

describe('CalculoCdbService', () => {
  let service: DesafioCDBServico;

  beforeEach(() => {
    TestBed.configureTestingModule({});
    service = TestBed.inject(DesafioCDBServico);
  });

  it('should be created', () => {
    expect(service).toBeTruthy();
  });
});

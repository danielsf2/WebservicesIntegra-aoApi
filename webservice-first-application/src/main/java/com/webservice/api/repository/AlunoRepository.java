package com.webservice.api.repository;

import com.webservice.api.models.Aluno;
import org.springframework.data.repository.CrudRepository;

public interface AlunoRepository extends CrudRepository<Aluno, Integer> { }

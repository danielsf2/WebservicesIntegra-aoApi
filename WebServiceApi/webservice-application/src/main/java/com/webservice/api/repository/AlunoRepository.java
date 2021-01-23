package com.webservice.api.repository;

import com.webservice.api.models.Aluno;
import org.springframework.data.repository.CrudRepository;

import java.util.List;
import java.util.Optional;

public interface AlunoRepository extends CrudRepository<Aluno, Integer> {}

package com.webservice.api.controller;

import com.webservice.api.models.Aluno;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.web.bind.annotation.*;
import com.webservice.api.repository.AlunoRepository;

import java.util.ArrayList;
import java.util.List;

@RestController
public class AlunoController {

    @Autowired
    AlunoRepository alunoRepository;

    @GetMapping(path = "/api/aluno/consultar/{codigo}")
    public List<Aluno> consultarId(@PathVariable("codigo") Integer codigo){

        List<Aluno> alunos = new ArrayList<>();

        for (var temp: alunoRepository.findAll())
            if(((Aluno)temp).getId_turma() == codigo)
                alunos.add(temp);

        return alunos;
    }

    @PostMapping(path = "/api/aluno/salvar")
    public Aluno salvarAluno(@RequestBody Aluno aluno){return alunoRepository.save(aluno);}

}//class AlunoController

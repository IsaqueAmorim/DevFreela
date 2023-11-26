﻿using DevFreela.Services.InputModels;
using DevFreela.Services.ViewModels;

namespace DevFreela.Services.Services.Interfaces
{
    public interface IProjectService
    {
        List<ProjectViewModel> GetAll();
        ProjectDetailsViewModel GetById(Guid id);
        Guid Create(NewProjectInputModel projectInputModel);
        void Update(UpdateProjectInputModel updateProjectInputModel);
        Guid CreateComment(NewCommentInputModel newCommentInputModel);
        void Delete(Guid id);
        void Start(Guid id);
        void Finish(Guid id);
    }
}